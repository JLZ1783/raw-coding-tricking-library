﻿<template>
  <item-content-layout v-if="profile">
    <template v-slot:content>
      <submission-feed :content-endpoint="`/api/users/${profile.id}/submissions`"/>
    </template>
    <template v-slot:item>
      <user-header :username="profile.username" :image-url="profile.image" :link="false"/>
      <v-divider class="my-2"/>
      <profile-completed-tricks :profile-submissions="profile.submissions"/>
    </template>
  </item-content-layout>
</template>

<script>
import ItemContentLayout from "@/components/item-content-layout";
import Submission from "@/components/submission";
import SubmissionFeed from "@/components/submission-feed";
import UserHeader from "@/components/user-header";
import ProfileCompletedTricks from "@/components/profile-completed-tricks";

export default {
  components: {ProfileCompletedTricks, UserHeader, SubmissionFeed, Submission, ItemContentLayout},
  data: () => ({
    profile: null
  }),
  async fetch() {
    const {username} = this.$route.params
    this.profile = await this.$axios.$get(`/api/users/${username}`)
  }
}
</script>

<style scoped>

</style>
